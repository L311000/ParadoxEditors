using ParadoxEditor_Base.Editor_Components;
using System;
using System.Collections.Generic;
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
        public Editor_Main()
        {
            InitializeComponent();
        }

        private void InitialiseEditor()
        {
            CreateDirectories_01();
            CreateFiles_02();
            LoadSettings_03();
        }

        private void CreateDirectories_01()
        {

        }

        private void CreateFiles_02()
        {

        }

        private void LoadSettings_03()
        {

        }
    }
}
