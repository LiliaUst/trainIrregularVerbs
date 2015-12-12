using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainIrregularVerbs
{
    /// <summary>
    /// Представляет собой тренировку
    /// </summary>
    internal class Train
    {
        private TrainData trainData;
        private int currentStep;
        private int indexStep;
        private Random random;

        internal int CountStep
        {
            get { return trainData.ListTrain.Count; }
        }

        internal Train()
        {
            trainData = new TrainData();
        }

        internal void Open()
        {
            currentStep = 0;
            indexStep = -1;
            OnStepReset(new EventArgs());
            trainData.Open();
            random = new RandomNotRepeat(0, CountStep);
        }

        internal void NextStep()
        {
            indexStep++;

            currentStep = random.Next();

            // Завершили процесс
            if (indexStep + 1 > trainData.ListTrain.Count)
            {
                Stop();
                return;
            }

            OnStepPrepared(new StepPreparedEventArgs(trainData.ListTrain[currentStep], indexStep + 1));
        }

        internal event EventHandler<TrainEndEventArgs> TrainEnd;
        protected virtual void OnTrainEnd(TrainEndEventArgs e)
        {
            EventHandler<TrainEndEventArgs> handler = TrainEnd;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        internal event EventHandler<EventArgs> StepReset;
        protected virtual void OnStepReset(EventArgs e)
        {
            EventHandler<EventArgs> handler = StepReset;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        internal event EventHandler<StepPreparedEventArgs> StepPrepared;
        protected virtual void OnStepPrepared(StepPreparedEventArgs e)
        {
            EventHandler<StepPreparedEventArgs> handler = StepPrepared;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        internal void Stop(int codeResult = 0)
        {
            OnStepReset(new EventArgs());
            OnTrainEnd(new TrainEndEventArgs(codeResult));
        }
    }

    internal class TrainEndEventArgs : EventArgs
    {
        private int codeResult;
        public int CodeResult
        {
            get { return codeResult; }
        }
        public TrainEndEventArgs(int codeResult = 0)
        {
            this.codeResult = codeResult;
        }
    }

    internal class StepPreparedEventArgs : EventArgs
    {
        private VerbData stepData;
        public VerbData StepData
        {
            get { return stepData; }
        }
        private int stepNumber;
        public int StepNumber
        {
            get { return stepNumber; }
        }
        public StepPreparedEventArgs(VerbData stepData, int stepNumber)
        {
            this.stepData = stepData;
            this.stepNumber = stepNumber;
        }
    }
    
}
