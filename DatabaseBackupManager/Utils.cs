using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace DatabaseBackupManager
{
    class Utils
    {
        private static string resourcesPath = Directory.GetParent("Resources.resx").Parent.Parent.FullName + @"\Properties\Resources.resx";

        public static string ReadResource(string key)
        {
            using (ResXResourceReader rsxr = new ResXResourceReader(resourcesPath))
            {
                foreach (DictionaryEntry d in rsxr)
                {
                    if (d.Key.ToString() == key)
                    {
                        return d.Value.ToString();
                    } 
                }
                return null;
            }
        }

        public static void AddOrUpdateResource(string key, string value)
        {
            var resx = new List<DictionaryEntry>();
            using (var reader = new ResXResourceReader(resourcesPath))
            {
                resx = reader.Cast<DictionaryEntry>().ToList();
                var existingResource = resx.Where(r => r.Key.ToString() == key).FirstOrDefault();
                if (existingResource.Key == null && existingResource.Value == null) // NEW!
                {
                    resx.Add(new DictionaryEntry() { Key = key, Value = value });
                }
                else // MODIFIED RESOURCE!
                {
                    var modifiedResx = new DictionaryEntry()
                    { Key = existingResource.Key, Value = value };
                    resx.Remove(existingResource);  // REMOVING RESOURCE!
                    resx.Add(modifiedResx);  // AND THEN ADDING RESOURCE!
                }
            }
            using (var writer = new ResXResourceWriter(resourcesPath))
            {
                resx.ForEach(r =>
                {
                    // Again Adding all resource to generate with final items
                    writer.AddResource(r.Key.ToString(), r.Value.ToString());
                });
                writer.Generate();
            }
        }

        public static void ChangeLanguage(string lang)
        {
            //ResourceManager rm = new ResourceManager("DatabaseBackupManager.Properties.Resources", Assembly.GetExecutingAssembly());
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
        }
    }
}
