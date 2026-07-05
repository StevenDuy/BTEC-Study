using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    public class EmailNotifier: INotifier
    {
        public void Notify(string message)
        {
            // Simulate sending an email notification
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
