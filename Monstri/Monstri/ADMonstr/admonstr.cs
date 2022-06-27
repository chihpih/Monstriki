using Monstri.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Monstri.admonstr
{
    internal class admonstr
    {
        public List<InfoMonstr> Monstrs { get; set; }
        private string _path;
        public admonstr (string path)
        {
            _path = path;
            Monstrs = GMonstrs();
        }
        public void file()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Monstrs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private List<InfoMonstr> GMonstrs()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    List<InfoMonstr> rec = formatter.Deserialize(fs) as List<InfoMonstr>;
                    fs.Close();
                    if (rec != null)
                        return rec;
                    else
                        return new List<InfoMonstr>();
                }
            }
            catch (SerializationException)
            {
                return new List<InfoMonstr>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add(string name, string yoa, string from, string peculiarities)
        {
            Monstrs.Add(new InfoMonstr(name, yoa, from,peculiarities));
            try
            {
                file();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}