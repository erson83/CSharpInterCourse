using System;

namespace InterfaceWithoutPoly
{

    public class Video
    {
        public Video video { get; set; }
    }

    public class Mail
    {
        public Mail mail { get; set; }
    }


    public class MailService
    {

        public void SendEmail(Mail mail)
        {
            Console.WriteLine("Sending email...");
        }

        public void SendSms(Mail mail)
        {
            Console.WriteLine("Sending sms...");
        }


    }

    public class VideoEncoder
    {
        private readonly MailService _mailService;

        public VideoEncoder()
        {
            _mailService = new MailService();
        }

        public void EncodeEmail(Video video)
        {
            _mailService.SendEmail(new Mail()); //This implies that after encoding a
                                           //video, the VideoEncoder uses the
                                           //MailService to send an email.
        }
        public void EncodeSMS(Video video)
        {
            _mailService.SendSms(new Mail()); //This implies that after encoding a
                                           //video, the VideoEncoder uses the
                                           //MailService to send an sms.
        }

    }


    class Program

    {

        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.EncodeEmail(new Video());
            encoder.EncodeSMS(new Video());
        }


    }
}
