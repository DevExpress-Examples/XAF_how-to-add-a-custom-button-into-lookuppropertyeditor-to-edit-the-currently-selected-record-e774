using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace WinSolution.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class WinSolutionWindowsFormsModule : ModuleBase {
        public WinSolutionWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
