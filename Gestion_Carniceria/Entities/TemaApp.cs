using System;

namespace Gestion_Carniceria.Entities
{
    public static class TemaApp
    {
        public static void AplicarTema(Form form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);

            foreach (Control control in form.Controls)
            {
                control.ForeColor = Color.White;

                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(50, 50, 50);
                    btn.FlatStyle = FlatStyle.Flat;
                }
            }
        }
    }
}