using GeneralComputing.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;

namespace GeneralComputing.ViewModels
{
    public class TimerViewModel : BaseViewModel
    {
        private static Timer aTimer = new Timer(100);
        private static DateTime startTime;
        private bool started = false;

        public ICommand StartTimerCommand { get { return new RelayCommand(OnStartTimer); } }
        public ICommand StopTimerCommand { get { return new RelayCommand(OnStopTimer); } }
        public ICommand ResetTimerCommand { get { return new RelayCommand(OnResetTimer); } }

        private void OnResetTimer(object obj)
        {
            aTimer.Close();
            started = false;
            myTimer = "00:00:00";
        }

        private void OnStopTimer(object obj)
        {
            aTimer.Stop();
        }

        private void OnStartTimer(object obj)
        {
            if (!started)
            {
                startTime = DateTime.Now;
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
                started = true;
            }
            else
            {
                aTimer.Start();
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            myTimer = e.SignalTime.Subtract(startTime).ToString(@"hh\:mm\:ss");
        }

        private string _timer;

        public string myTimer
        {
            get { return _timer; }
            set { SetProperty(ref _timer, value); }
        }
    }
}