using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notifficationChannels;

        public VideoEncoder()
        {
            _notifficationChannels = new List<INotificationChannel>();
        }

        public void Encode (Video video)
        {
            //..
            //..
            foreach (var channel in _notifficationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notifficationChannels.Add(channel);
        }

    }
}
