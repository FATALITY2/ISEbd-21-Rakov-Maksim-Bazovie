﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsCrane
{
    public class ParkingCollection
    {

        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"ParkingCollection");

                    foreach (var level in parkingStages)
                    {
                        sw.WriteLine($"Parking{separator}{level.Key}");

                        ITransport crane = null;

                        for (int i = 0; (crane = level.Value.GetNext(i)) != null; i++)
                        {
                            if (crane != null)
                            {
                                if (crane.GetType().Name == "Crane")
                                {
                                    sw.Write($"Crane{separator}");
                                }
                                if (crane.GetType().Name == "SuperCrane")
                                {
                                    sw.Write($"SuperCrane{separator}");
                                }

                                sw.WriteLine(crane);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            string str = "";

            using (StreamReader sr = new StreamReader(filename))
            {
                str = sr.ReadLine();

                if (str.Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    return false;
                }

                str = sr.ReadLine();
                Vehicle crane = null;
                string key = string.Empty;

                while (str != null && str.Contains("Parking"))
                {
                    if (str.Contains("Parking"))
                    {
                        key = str.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }

                    str = sr.ReadLine();

                    while (str != null && (str.Contains("Crane") || str.Contains("SuperCrane")))
                    {
                        if (str.Split(separator)[0] == "Crane")
                        {
                            crane = new Crane(str.Split(separator)[1]);
                        }
                        else if (str.Split(separator)[0] == "SuperCrane")
                        {
                            crane = new SuperCrane(str.Split(separator)[1]);
                        }

                        var result = parkingStages[key] + crane;

                        if (!result)
                        {
                            return false;
                        }

                        str = sr.ReadLine();
                    }
                }
                return true;
            }
        }
    }
}