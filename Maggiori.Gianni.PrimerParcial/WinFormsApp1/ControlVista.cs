using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaAerolinea {
	public static class ControlVista {

		internal static bool ValidarTextBox(Form form) {
			foreach(Control	control in form.Controls) {
				if(control is TextBox && string.IsNullOrEmpty(control.Text)) {
					return false;
				}
			}
			return true;
		}
		internal static void AbrirForm(Form formPadre, Form formHijo) {
			if (Application.OpenForms[formHijo.GetType().Name] != null){
                Application.OpenForms[formHijo.GetType().Name].Activate();
            }
            else{
				formHijo.MdiParent = formPadre;
                formHijo.Show();
			}
		}
		internal static void Salir(Form formPadre) {
            Form frm = formPadre.ActiveMdiChild;
            if (frm != null){
                frm.Close();
            }
            else{
                Application.Exit();
            }
        }
	}
}
