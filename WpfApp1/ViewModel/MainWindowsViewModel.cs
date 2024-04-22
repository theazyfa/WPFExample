using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class MainWindowsViewModel
    {

        //le type ObservableCollection permet de recevoir des événements en cas d'ajout ou de retrait
        public ObservableCollection<BackupJob> Jobs { get; set;  } = new ObservableCollection<BackupJob>();

        public void AddBackupJob()
        {
            BackupJob job = new BackupJob();
            job.Name = "Jobs";
            job.Progress = 0;
            job.Start();
            Jobs.Add(job);
        }

    }
}
