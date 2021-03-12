
using System;
using System.Windows.Forms;

namespace LumoNotificaciones
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkLabelDashboards = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevaActualizacion = new System.Windows.Forms.PictureBox();
            this.nuevoMensaje = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.listViewMensajes = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblCargando = new System.Windows.Forms.Label();
            this.timerActualizaciones = new System.Windows.Forms.Timer(this.components);
            this.wbSinMensajes = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.timerInventario = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevaActualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked_1);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // linkLabelDashboards
            // 
            resources.ApplyResources(this.linkLabelDashboards, "linkLabelDashboards");
            this.linkLabelDashboards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.linkLabelDashboards.LinkColor = System.Drawing.Color.White;
            this.linkLabelDashboards.Name = "linkLabelDashboards";
            this.linkLabelDashboards.TabStop = true;
            this.linkLabelDashboards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDashboards_LinkClicked);
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.nuevaActualizacion);
            this.panel1.Controls.Add(this.nuevoMensaje);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.linkLabelDashboards);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnActualizar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // nuevaActualizacion
            // 
            resources.ApplyResources(this.nuevaActualizacion, "nuevaActualizacion");
            this.nuevaActualizacion.Name = "nuevaActualizacion";
            this.nuevaActualizacion.TabStop = false;
            this.nuevaActualizacion.Click += new System.EventHandler(this.nuevaActualizacion_Click);
            // 
            // nuevoMensaje
            // 
            resources.ApplyResources(this.nuevoMensaje, "nuevoMensaje");
            this.nuevoMensaje.Name = "nuevoMensaje";
            this.nuevoMensaje.TabStop = false;
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVersion.Name = "lblVersion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            resources.ApplyResources(this.btnRegresar, "btnRegresar");
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            resources.ApplyResources(this.btnActualizar, "btnActualizar");
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // listViewMensajes
            // 
            this.listViewMensajes.BackColor = System.Drawing.Color.White;
            this.listViewMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listViewMensajes, "listViewMensajes");
            this.listViewMensajes.HideSelection = false;
            this.listViewMensajes.LargeImageList = this.imageList;
            this.listViewMensajes.MultiSelect = false;
            this.listViewMensajes.Name = "listViewMensajes";
            this.listViewMensajes.Scrollable = false;
            this.listViewMensajes.SmallImageList = this.imageList;
            this.listViewMensajes.StateImageList = this.imageList;
            this.listViewMensajes.UseCompatibleStateImageBehavior = false;
            this.listViewMensajes.View = System.Windows.Forms.View.Tile;
            this.listViewMensajes.SelectedIndexChanged += new System.EventHandler(this.listViewMensajes_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "comunicacion.png");
            this.imageList.Images.SetKeyName(1, "Dashboard.png");
            this.imageList.Images.SetKeyName(2, "KPI.png");
            // 
            // lblCargando
            // 
            resources.ApplyResources(this.lblCargando, "lblCargando");
            this.lblCargando.Name = "lblCargando";
            // 
            // timerActualizaciones
            // 
            this.timerActualizaciones.Enabled = true;
            this.timerActualizaciones.Interval = 1000;
            this.timerActualizaciones.Tick += new System.EventHandler(this.timerActualizaciones_Tick);
            // 
            // wbSinMensajes
            // 
            resources.ApplyResources(this.wbSinMensajes, "wbSinMensajes");
            this.wbSinMensajes.Name = "wbSinMensajes";
            this.wbSinMensajes.ScrollBarsEnabled = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // timerInventario
            // 
            this.timerInventario.Interval = 1000;
            this.timerInventario.Tick += new System.EventHandler(this.timerInventario_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wbSinMensajes);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.listViewMensajes);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevaActualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel linkLabelDashboards;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private Button btnActualizar;
        private Label lblVersion;
        private ListView listViewMensajes;
        private ImageList imageList;
        private Button btnRegresar;
        private Label lblCargando;
        private PictureBox nuevoMensaje;
        private Timer timerActualizaciones;
        private WebBrowser wbSinMensajes;
        private PictureBox nuevaActualizacion;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Timer timerInventario;
    }
}

