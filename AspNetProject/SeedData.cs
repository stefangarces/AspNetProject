using AspNetProject.Data;
using AspNetProject.Models;
using System;

namespace AspNetProject
{
    public class SeedData
    {
        public static void StartSeed(AspNetProjectContext context)
        {
            context.Attendee.RemoveRange(context.Attendee);
            context.Event.RemoveRange(context.Event);

            context.Attendee.Add(new Attendee
            {
                UserName = "Bjorn",
                Email = "bjornstromberg@codic.se",
                PhoneNumber = "0700-001001"
            });

            context.Event.Add(new Event
            {
                Title = "Carola",
                Description = "Fantastisk show!",
                Place = "Annexet",
                Adress = "Stockholmsgatan 14",
                Date = DateTime.Parse("2022-05-22"),
                TicketsAvailable = true
            });
            context.Event.Add(new Event
            {
                Title = "Evert Taube",
                Description = "Otrolig show!",
                Place = "Flen Arena",
                Adress = "Flengatan 122",
                Date = DateTime.Parse("2022-05-22"),
                TicketsAvailable = true
            });
            context.Event.Add(new Event
            {
                Title = "Vikingarna",
                Description = "Kom och njut av odödliga klassiker!",
                Place = "Nya Ullevi",
                Adress = "Göteborgsgatan 14",
                Date = DateTime.Parse("2022-05-22"),
                TicketsAvailable = true
            });
            context.Event.Add(new Event
            {
                Title = "BTS",
                Description = "Pojkbandet från Korea har landet i Sverige!",
                Place = "Ericsson Globe",
                Adress = "Stockholmsgatan 22",
                Date = DateTime.Parse("2024-02-27"),
                TicketsAvailable = false
            });
            context.SaveChanges();
        }
    }
}
