﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Inventor;


namespace lesson1_VS2017_CSharp_Complete
{
    public partial class Form1 : Form
    {
        Inventor.Application _invApp;
        bool _started = false;

        public Form1()
        {
            InitializeComponent();
            try
            {
                _invApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");

            }
            catch (Exception ex)
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _invApp = (Inventor.Application)System.Activator.CreateInstance(invAppType);
                    _invApp.Visible = true;

                    _started = true;

                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString());
                    MessageBox.Show("Unable to get or start Inventor");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Add code for Lesson 1 here

            if (_invApp.Documents.Count == 0)
            {
                MessageBox.Show("Need to open an Assembly document");
                return;
            }

            if (_invApp.ActiveDocument.DocumentType != DocumentTypeEnum.kAssemblyDocumentObject)
            {
                MessageBox.Show("Need to have an Assembly document active");
                return;
            }

            AssemblyDocument asmDoc = default(AssemblyDocument);
            asmDoc = (AssemblyDocument)_invApp.ActiveDocument;

            if (asmDoc.SelectSet.Count == 0)
            {
                MessageBox.Show("Need to select a Part or Sub Assembly");
                return;
            }

            SelectSet selSet = default(SelectSet);
            selSet = asmDoc.SelectSet;

            try
            {
                ComponentOccurrence compOcc = default(ComponentOccurrence);
                object obj = null;
                foreach (object obj_loopVariable in selSet)
                {
                    obj = obj_loopVariable;
                    compOcc = (ComponentOccurrence)obj;
                    System.Diagnostics.Debug.Print(compOcc.Name);
                    compOcc.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Is the selected item a Component?");
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
