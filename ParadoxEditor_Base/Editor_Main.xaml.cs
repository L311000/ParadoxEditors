using ParadoxEditor_Base.Editor_Components;
using ParadoxEditor_Base.IO;
using ParadoxEditor_Base.P_Shared_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ParadoxEditor_Base
{
    /// <summary>
    /// Interaction logic for Editor_Main.xaml
    /// </summary>
    public partial class Editor_Main : Window
    {
        public EditorSettings Settings { get; set; } = new();
        public string PathFileSettings { get; set; }
        public string PathDirectoryExe { get; set; }
        public string PathDirectoryMods { get; set; }
        public string PathDirectoryEditorLocalisations { get; set; }
        public string PathDirectoryEditorImages { get; set; }
        public LocalisationCollection EditorLocalisations { get; set; }
        public Editor_Main()
        {
            InitializeComponent();
            InitialiseEditor();
        }

        private void InitialiseEditor()
        {
            Mehlmann_Shared.IO.Exporter.ExcludesTypes.Add(typeof(Localisation));

            SetDirectoryPaths_01();

            CreateDirectories_02();

            LoadSettings_04();

            CreateFiles_03();
        }

        #region Initialise Editor

        private void SetDirectoryPaths_01()
        {
            string exe = System.Reflection.Assembly.GetExecutingAssembly().Location;
            PathDirectoryExe = System.IO.Path.GetDirectoryName(exe);

            string editorDir = PathDirectoryExe + @"\Editor";

            PathDirectoryEditorLocalisations = editorDir + @"\Localisations";
            PathDirectoryEditorImages = editorDir + @"\Images";

            PathDirectoryMods = PathDirectoryExe + @"\Mods";

        }

        private void CreateDirectories_02()
        {
            if (!Directory.Exists(PathDirectoryEditorLocalisations))
            {
                Directory.CreateDirectory(PathDirectoryEditorLocalisations);
                Globals.CreateLanguageDirectories(PathDirectoryEditorLocalisations);
            }
            if (!Directory.Exists(PathDirectoryEditorImages))
            {
                Directory.CreateDirectory(PathDirectoryEditorImages);
            }
            if (!Directory.Exists(PathDirectoryMods))
            {
                Directory.CreateDirectory(PathDirectoryMods);
            }
        }

        private void CreateFiles_03() //TO DO
        {
            PathFileSettings = PathDirectoryExe + @"\Settings.xml";
            if (!File.Exists(PathFileSettings))
            {
                Settings = new();
                var f = File.Create(PathFileSettings);
                f.Close();
                Mehlmann_Shared.IO.Exporter.Export(Settings, PathFileSettings);
            }
        }

        private void LoadSettings_04() //TO DO
        {
            Settings = new();
            
        }
        private void LoadEditorLocalisations_05() //TO DO
        {

        }




        #endregion

        private void Window_Editor_Main_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
