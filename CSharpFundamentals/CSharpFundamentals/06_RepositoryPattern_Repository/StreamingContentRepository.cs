using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();
        public int MyProperty { get; set; }
            
            //create
            public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

            //read
            public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }


        //update

        public void UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //FindContent  
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
                 
                

                // B
                // C
                // D
            }
            else
            {
                return false; 
            }

        }

        //delete

        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if(content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

           }

        //Helper Method
        private StreamingContent GetContentByTitle(String title)
        {
            foreach (StreamingContent content in _listOfContent)
            {
                if (content.Title == title)
                {
                    return content;
                }
                

            }
            return null;
        }
      

    }
}
