using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Compute
{
    public struct Meeting
    {
        public long StartTime;
        public long EndTime;

        public Meeting(long sTime, long eTime)
        {
            StartTime = sTime;
            EndTime = eTime;
        }
    }

    public class Room
    {
        public List<Meeting> Meetings;

        public Room()
        {
            Meetings = new List<Meeting>();
        }
        public bool try_schedule_meeting(Meeting meeting)
        {
            foreach (Meeting scheduledMeeting in Meetings)
            {
                if ((meeting.StartTime < scheduledMeeting.EndTime) && (meeting.EndTime > scheduledMeeting.StartTime))
                    return false;
            }

            Meetings.Add(meeting);
            return true;
        }
    }

    public class Scheduler
    {
        List<Room> _rooms;

        public Scheduler()
        {
            _rooms = new List<Room>();
        }
        public List<Room> schedule_meetings(List<Meeting> meetings)
        {
            for (int i = 0; i < meetings.Count; ++i)
            {
                bool isMeetingScheduled = false;
                foreach (Room room in _rooms)
                {
                    if (room.try_schedule_meeting(meetings[i]))
                    {
                        isMeetingScheduled = true;
                        break;
                    }
                }

                if (!isMeetingScheduled)
                {
                    Room newRoom = new Room();
                    newRoom.try_schedule_meeting(meetings[i]);
                    _rooms.Add(newRoom);
                }
            }

            return _rooms;
        }
    }
}