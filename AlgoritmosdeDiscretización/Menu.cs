using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosdeDiscretización
{
    internal class FormManager
    {
        private static FrmBresenhamCircumference _frmBreBresenhamCircumference;
        private static FrmDDACircumference _DDACircumference;



        public static FrmDDACircumference GetFrmDDACircumference()
        {
            if (_DDACircumference == null || _DDACircumference.IsDisposed)
            {
                // Si no existe una instancia o si fue cerrada, creamos una nueva.
                _DDACircumference = new FrmDDACircumference();
            }
            else
            {
                // Si ya existe y está minimizado, lo restauramos.
                if (_DDACircumference.WindowState == FormWindowState.Minimized)
                {
                    _DDACircumference.WindowState = FormWindowState.Maximized; // Restaura el formulario si estaba minimizado.
                }
                // Traemos el formulario al frente.
                _DDACircumference.BringToFront();
                _DDACircumference.Focus();
            }
            return _DDACircumference;
        }


        public static FrmBresenhamCircumference GetFrmBresenhamCircumference()
        {
            if (_frmBreBresenhamCircumference == null || _frmBreBresenhamCircumference.IsDisposed)
            {
                // Si no existe una instancia o si fue cerrada, creamos una nueva.
                _frmBreBresenhamCircumference = new FrmBresenhamCircumference();
            }
            else
            {
                // Si ya existe y está minimizado, lo restauramos.
                if (_frmBreBresenhamCircumference.WindowState == FormWindowState.Minimized)
                {
                    _frmBreBresenhamCircumference.WindowState = FormWindowState.Maximized; // Restaura el formulario si estaba minimizado.
                }
                // Traemos el formulario al frente.
                _frmBreBresenhamCircumference.BringToFront();
                _frmBreBresenhamCircumference.Focus();
            }
            return _frmBreBresenhamCircumference;
        }

    }
}
