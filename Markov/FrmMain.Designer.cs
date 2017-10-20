namespace Markov
{
	partial class FrmMain
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.BtnDo = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnMarkov = new System.Windows.Forms.Button();
            this.TxtMarkov = new System.Windows.Forms.TextBox();
            this.TxtDirty = new System.Windows.Forms.TextBox();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(280, 12);
            this.TxtSource.Multiline = true;
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(260, 91);
            this.TxtSource.TabIndex = 0;
            // 
            // BtnDo
            // 
            this.BtnDo.Location = new System.Drawing.Point(280, 109);
            this.BtnDo.Name = "BtnDo";
            this.BtnDo.Size = new System.Drawing.Size(259, 24);
            this.BtnDo.TabIndex = 1;
            this.BtnDo.Text = "分かち書き";
            this.BtnDo.UseVisualStyleBackColor = true;
            this.BtnDo.Click += new System.EventHandler(this.BtnDo_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(280, 139);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(260, 104);
            this.TxtResult.TabIndex = 2;
            // 
            // BtnMarkov
            // 
            this.BtnMarkov.Location = new System.Drawing.Point(546, 12);
            this.BtnMarkov.Name = "BtnMarkov";
            this.BtnMarkov.Size = new System.Drawing.Size(27, 231);
            this.BtnMarkov.TabIndex = 3;
            this.BtnMarkov.Text = "マルコフ";
            this.BtnMarkov.UseVisualStyleBackColor = true;
            this.BtnMarkov.Click += new System.EventHandler(this.BtnMarkov_Click);
            // 
            // TxtMarkov
            // 
            this.TxtMarkov.Location = new System.Drawing.Point(579, 12);
            this.TxtMarkov.Multiline = true;
            this.TxtMarkov.Name = "TxtMarkov";
            this.TxtMarkov.Size = new System.Drawing.Size(294, 231);
            this.TxtMarkov.TabIndex = 4;
            // 
            // TxtDirty
            // 
            this.TxtDirty.Location = new System.Drawing.Point(12, 12);
            this.TxtDirty.Multiline = true;
            this.TxtDirty.Name = "TxtDirty";
            this.TxtDirty.Size = new System.Drawing.Size(229, 91);
            this.TxtDirty.TabIndex = 5;
            // 
            // BtnReplace
            // 
            this.BtnReplace.Location = new System.Drawing.Point(12, 109);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(229, 24);
            this.BtnReplace.TabIndex = 6;
            this.BtnReplace.Text = "Clean";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(247, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(27, 91);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "→追加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 101);
            this.label1.TabIndex = 8;
            this.label1.Text = "①メール本文（１通分）を上のテキストボックスにコピーする。\r\n②追加ボタンを押す\r\n③１と２を繰り返す\r\n④程よく溜まったら分かち書きする\r\n⑤マルコフする\r\n";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.TxtDirty);
            this.Controls.Add(this.TxtMarkov);
            this.Controls.Add(this.BtnMarkov);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnDo);
            this.Controls.Add(this.TxtSource);
            this.Name = "FrmMain";
            this.Text = "マルコフ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtSource;
		private System.Windows.Forms.Button BtnDo;
		private System.Windows.Forms.TextBox TxtResult;
		private System.Windows.Forms.Button BtnMarkov;
		private System.Windows.Forms.TextBox TxtMarkov;
		private System.Windows.Forms.TextBox TxtDirty;
		private System.Windows.Forms.Button BtnReplace;
		private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
	}
}

