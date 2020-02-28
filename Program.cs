// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9E4278D-47AE-470E-9EF1-D704984CCD16
// Assembly location: C:\Users\cktau\Desktop\TSM WoWhead Grouper\WindowsFormsApplication1.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {

    internal static class Program {

        #region Methods

        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion Methods
    }
}