using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsCrane
{
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий парковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }

            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"ParkingCollection");
                    foreach (var level in parkingStages)
                    {
                        sw.WriteLine($"Parking{separator}{level.Key}");                       
                            foreach (ITransport crane in level.Value)
                            {
                                    if (crane.GetType().Name == "Crane")
                                    {                                        
                                        sw.Write($"Crane{separator}");
                                    }
                                if (crane.GetType().Name == "SuperCrane")
                                {
                                    sw.Write($"SuperCrne{separator}");
                                }
                                //Записываемые параметры
                                sw.WriteLine(crane);
                            }
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException("Неверный формат файла");
                }
                line = sr.ReadLine();
                Vehicle crane = null;
                string key = string.Empty;
                while (line != null && line.Contains("Parking"))
                {
                    key = line.Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(pictureWidth,
                   pictureHeight));
                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Crane") || line.Contains("SuperCrane")))
                    {
                        if (line.Split(separator)[0] == "Crane")
                        {
                            crane = new Crane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "SuperCrane")
                        {
                            crane = new SuperCrane(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + crane;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}