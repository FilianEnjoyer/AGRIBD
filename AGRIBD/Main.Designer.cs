namespace AGRIBD
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarCultivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = global::AGRIBD.Properties.Resources.Strip;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.productoresToolStripMenuItem,
            this.cultivosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(155, 558);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.AutoSize = false;
            this.logInToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.logInToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(130, 45);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logInToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.AutoSize = false;
            this.buscarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.buscarToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Buscar;
            this.buscarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(130, 45);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // productoresToolStripMenuItem
            // 
            this.productoresToolStripMenuItem.AutoSize = false;
            this.productoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registraToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.asignarCultivoToolStripMenuItem});
            this.productoresToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoresToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.productoresToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Productor;
            this.productoresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productoresToolStripMenuItem.Name = "productoresToolStripMenuItem";
            this.productoresToolStripMenuItem.Size = new System.Drawing.Size(130, 45);
            this.productoresToolStripMenuItem.Text = "Productores";
            this.productoresToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // registraToolStripMenuItem
            // 
            this.registraToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Añadir_Productor;
            this.registraToolStripMenuItem.Name = "registraToolStripMenuItem";
            this.registraToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.registraToolStripMenuItem.Text = "Registrar";
            this.registraToolStripMenuItem.Click += new System.EventHandler(this.registraToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Editar_Productor;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Eliminar_Productor;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // asignarCultivoToolStripMenuItem
            // 
            this.asignarCultivoToolStripMenuItem.Name = "asignarCultivoToolStripMenuItem";
            this.asignarCultivoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.asignarCultivoToolStripMenuItem.Text = "Asignar Cultivo";
            this.asignarCultivoToolStripMenuItem.Click += new System.EventHandler(this.asignarCultivoToolStripMenuItem_Click);
            // 
            // cultivosToolStripMenuItem
            // 
            this.cultivosToolStripMenuItem.AutoSize = false;
            this.cultivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.cultivosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cultivosToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.cultivosToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Cultivo;
            this.cultivosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cultivosToolStripMenuItem.Name = "cultivosToolStripMenuItem";
            this.cultivosToolStripMenuItem.Size = new System.Drawing.Size(130, 45);
            this.cultivosToolStripMenuItem.Text = "Cultivos";
            this.cultivosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cultivosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cultivosToolStripMenuItem.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Añadir_Cultivo;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = global::AGRIBD.Properties.Resources.Editar_Cultivo;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Image = global::AGRIBD.Properties.Resources.Eliminar_Cultivo;
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.AutoSize = false;
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.reportesToolStripMenuItem.Image = global::AGRIBD.Properties.Resources.Reportes;
            this.reportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(130, 45);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 558);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignarCultivoToolStripMenuItem;
    }
}

