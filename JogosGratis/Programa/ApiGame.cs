using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosGratis.Programa
{
    internal class ApiGame
    {

        private string id;
        private string title;
        private string thumbnail;
        public string  genre;
        private string publisher;
        private string developer;
        
        

        public string Id
        {  get { return id; } set { id = value; } }

        public string Title
            { get { return title; } set { title = value; } }

        public string Thumbnail
            { get { return thumbnail; } set { thumbnail = value; } }

        public string Genre
        { get { return genre; } set  { genre = value; } }


        public string Publisher
            { get { return publisher; } set { publisher = value; } }

        public string Developer
            { get { return developer; } set { developer = value; } }

       

    }
}
