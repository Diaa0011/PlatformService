using System;

namespace CommandsService.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLine { get; set; }
        public string PlatformId { get; set; }
    }
}