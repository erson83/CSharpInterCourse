using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace InterfaceWithPoly
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending sms....");
        }
    }


    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail....");
        }
    }




    public interface INotificationChannel
    {
        void Send(Message message);
    }

    public class Message
    {

    }

    public class Video
    {
        public Video video { get; set; }
    }

    public class Mail
    {
        public Mail mail { get; set; }
    }

    public class VideoEncoder

       // The VideoEncoder class is responsible for encoding videos and notifying registered notification channels about
       // the encoding process.It maintains a private list _notificationChannels of INotificationChannel objects.
    {
        private readonly IList<INotificationChannel> _notificationChannels;
    public VideoEncoder()
    {
        _notificationChannels = new List<INotificationChannel>();
    }
    public void Encode(Video video)
    {
        foreach (var channel in _notificationChannels)
            channel.Send(new Message());
    }
    public void RegisterNotificationChannel(INotificationChannel channel)
         //   The RegisterNotificationChannel method is called on the encoder object to add a MailNotificationChannel
         //   and a SmsNotificationChannel to the list of notification channels.

    {
        _notificationChannels.Add(channel);
    }
}
class Program
{

        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());  // adding in MailNotificationChannel as a Interface
            encoder.RegisterNotificationChannel(new SmsNotificationChannel()); // adding in SmsNotificationChannel as a Interface
            encoder.Encode(new Video());
        }


    }
}
