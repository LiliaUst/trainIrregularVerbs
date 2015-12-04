using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainIrregularVerbs
{
    public partial class frmMain : Form
    {
        private Train currentTrain;

        private readonly string templateVerb;
        private readonly string templateFromTo;

        public frmMain()
        {
            templateVerb = "{0} – {1}";
            templateFromTo = "from {0} to {1}";

            InitializeComponent();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to stop this training?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                currentTrain.Stop(1);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            currentTrain.NextStep();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            currentTrain = new Train();
            currentTrain.StepReset += new EventHandler<EventArgs>(currentTrain_StepReset);
            currentTrain.TrainEnd += new EventHandler<TrainEndEventArgs>(currentTrain_TrainEnd);
            currentTrain.StepPrepared += new EventHandler<StepPreparedEventArgs>(currentTrain_StepPrepared);

            StartTrain();
        }

        void currentTrain_StepReset(object sender, EventArgs e)
        {
            lbTrain.Text = "";
            lbEngVerb3Form.Text = "";
            lbPronuncVerb.Text = "";
            lbRusVerbInd.Text = "";
            gbDetail.Visible = false;

            lbFromTo.Text = "";
            pbProgress.Value = 0;
            pbProgress.Visible = false;
            btNext.Visible = false;
            btStop.Visible = false;

            btStart.Visible = true;
        }

        void currentTrain_StepPrepared(object sender, StepPreparedEventArgs e)
        {
            e.StepData.PreparingTrainVerb();
            lbTrain.Text = String.Format(templateVerb, e.StepData.EnglishPhrase, e.StepData.RussianPhrase);
            lbEngVerb3Form.Text = e.StepData.EnglishVerb;
            lbPronuncVerb.Text = e.StepData.EnglishPronunciation;
            lbRusVerbInd.Text = e.StepData.RussianVerbIndefinite;
            
            lbFromTo.Text = String.Format(templateFromTo, e.StepNumber, currentTrain.CountStep);
            pbProgress.Value = e.StepNumber;
        }

        void currentTrain_TrainEnd(object sender, TrainEndEventArgs e)
        {
            if (e.CodeResult == 0)
            {
                MessageBox.Show("You are a star!", "Bingo!");
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            StartTrain();
        }

        private void StartTrain()
        {
            currentTrain.Open();
            currentTrain.NextStep();

            pbProgress.Maximum = currentTrain.CountStep;

            gbDetail.Visible = true;
            pbProgress.Visible = true;
            btNext.Visible = true;
            btStop.Visible = true;
            btStart.Visible = false;

        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            //MediaPlayer pl = new MediaPlayer();
        }
    }
}
