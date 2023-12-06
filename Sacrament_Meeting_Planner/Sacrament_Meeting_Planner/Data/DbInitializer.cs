using Sacrament_Meeting_Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sacrament_Meeting_Planner.Data

{

    public static class DbInitializer

    {

        public static void Initialize(SacramentContext context)

        {

            context.Database.EnsureCreated();



            if (context.Meetings.Any())

            {

                return;

            }

            var meetings = new Meeting[]

            {

                new Meeting

                {

                    DateOfMeeting = DateTime.Parse("2023-01-01"),

                    Leader = "John Doe",

                    OpeningHymn = "123",

                    SacramentHymn = "456",

                    ClosingHymn = "789",

                    IntermediateNumber = "321",

                    OpeningPrayer = "Jane Doe",

                    ClosingPrayer = "Bob Smith",

                    MeetingSpeakers = new List<Speaker>

                    {

                        new Speaker { SpeakerName = "Speaker 1", Topic = "Topic 1", SpeakerPosition = 1 },

                        new Speaker { SpeakerName = "Speaker 2", Topic = "Topic 2", SpeakerPosition = 2 }

                    }

                },

            };

            foreach (Meeting m in meetings)

            {

                context.Meetings.Add(m);

            }

            context.SaveChanges();

        }

    }

}