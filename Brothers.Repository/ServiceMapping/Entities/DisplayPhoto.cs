using Brothers.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brothers.Repository.ServiceMapping.Entities
{
    public class DisplayPhoto
    {
        public DisplayPhoto()
        {
        }

        public DisplayPhoto(Photo photo)
        {
            Id = photo.Id;
            Name = photo.Name;
            Type = photo.Type.ToString();
            Size = photo.Size;
        }

        public DisplayPhoto(int id, int size, string name, ContentType type)
        {
            Id = id;
            Name = name;
            Type = type.ToString();
            Size = size;
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Size { get; set; }
    }
}