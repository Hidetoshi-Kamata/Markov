using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NMeCab;

namespace Markov
{
	public partial class FrmMain : Form
	{
		MeCabTagger tagger;
		List<String> sentences;

		public FrmMain()
		{
			tagger = MeCabTagger.Create();
			tagger.LatticeLevel = MeCabLatticeLevel.Zero;
			tagger.OutPutFormatType = "wakati";

			InitializeComponent();
		}

		private void BtnDo_Click(object sender, EventArgs e)
		{
			sentences = new List<String>();
			foreach (var sentence in TxtSource.Text.Split('\n'))
			{
				sentences.Add(tagger.Parse(sentence.Trim('\r', '\n', ' ')));
			}
			TxtResult.Text = String.Join("\n", sentences.ToArray());
		}

		private void BtnMarkov_Click(object sender, EventArgs e)
		{
			var markov = new Markov(4);
			foreach (var item in sentences)
			{
				markov.AddTable(item);
			}
			TxtMarkov.Text = markov.Generate();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
		}

		private void BtnReplace_Click(object sender, EventArgs e)
		{
			TxtDirty.Text = "";
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			TxtSource.Text += "\r\n" + clean(TxtDirty.Text);
		}
		private String clean(String source)
		{
			var dest = source.Replace("\r\n", "");
			dest = dest.Replace(" ", "");
			dest = dest.Replace("　", "");
			return dest;
		}
	}
}
