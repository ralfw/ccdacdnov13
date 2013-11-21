using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Collections.Generic;
namespace GuiUnitTester
    {
    [TestClass]
    public class UnitTest1
        {
        List<int> _TestDigits=new List<int>();
        List<int> _SollDigits = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<char> _TestOps = new List<char>();
        List<char> _SollOps = new List<char>() { '+', '-', '*', '/', '=' };
        /// <summary>
        /// Erwartet, dass die Ziffern in aufsteigender Reihenfolge und die
        /// Operatoren von Oben nach Unten gedrückt werden.
        /// </summary>
        [TestMethod]
        public void PressAllKeys()
            {
            //Arrange
            _TestDigits.Clear();
            _TestOps.Clear();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UI.Gui Form = new UI.Gui();
            Form.Ziffer_gedrückt += Form_Ziffer_gedrückt;
            Form.Op_gedrückt += Form_Op_gedrückt;
            //Action
            Application.Run(Form);
            //Assert
            Assert.AreEqual(_SollDigits.Count, _TestDigits.Count);
            for (int I = 0; I < _SollDigits.Count; I++)
                {
                Assert.AreEqual(_SollDigits[I], _TestDigits[I]);
                }
            Assert.AreEqual(_SollOps.Count, _TestOps.Count);
            for (int I = 0; I < _SollOps.Count; I++)
                {
                Assert.AreEqual(_SollOps[I], _TestOps[I]);
                }
            }
       
        void Form_Op_gedrückt(char obj)
            {
            _TestOps.Add(obj);
            }

        void Form_Ziffer_gedrückt(int obj)
            {
            _TestDigits.Add(obj);
            }
        }
    }
