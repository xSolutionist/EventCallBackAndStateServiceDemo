using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCallBackAndStateServiceDemo.Services
{
    public class NotificationService : INotificationService
    {
        public int Count { get; set; } = 0;

        public event Action OnChange;

        public void IncrementCounter()
        {
            Count++;
            OnChange?.Invoke();
        }

        public void ResetCounter()
        {
            Count = 0;
            OnChange?.Invoke();
        }
    }
    public interface INotificationService
    {
        event Action OnChange;
        int Count { get; set; }
        void IncrementCounter();
        void ResetCounter();
    }
}
