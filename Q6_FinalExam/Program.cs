using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net.NetworkInformation;

namespace Q6_FinalExam
{
    public class PlayerSettings
    {
        public string Player_Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public string[] Inventory { get; set; }
        public string License_Key { get; set; }

        private static PlayerSettings instance;

        private PlayerSettings()
        {
            // Private constructor to enforce singleton pattern
        }

        public static PlayerSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerSettings();
                }
                return instance;
            }
        }

        public void LoadSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                instance = JsonConvert.DeserializeObject<PlayerSettings>(json);
                Console.WriteLine("Settings loaded successfully.");
            }
            else
            {
                Console.WriteLine("Settings file not found. Using default settings.");
            }
        }

        public void SaveSettings(string filePath)
        {
            string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Settings saved successfully.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string settingsFilePath = "c:/templates/finalexam.json";

            // Load settings from file or use default values
            PlayerSettings.Instance.LoadSettings(settingsFilePath);

            // Display current settings
            Console.WriteLine("Current Player Settings:");
            Console.WriteLine($"Player Name: {PlayerSettings.Instance.Player_Name}");
            Console.WriteLine($"Level: {PlayerSettings.Instance.Level}");
            Console.WriteLine($"HP: {PlayerSettings.Instance.HP}");
            Console.WriteLine($"Inventory: {string.Join(", ", PlayerSettings.Instance.Inventory)}");
            Console.WriteLine($"License Key: {PlayerSettings.Instance.License_Key}");

            // Modify settings (for example, level up)
            PlayerSettings.Instance.Level++;

            // Save modified settings to file
            PlayerSettings.Instance.SaveSettings(settingsFilePath);
        
        }
    }
}
