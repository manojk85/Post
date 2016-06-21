using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wPostEntities;
using wPostRepositories;

namespace wPost.ViewModels
{
    public class PostViewModel : INotifyPropertyChanged
    {
       
        private readonly IPostRepository _iPostRepository;
        
        /// <summary>
        /// Instatiates all the variables
        /// </summary>
        public PostViewModel()
        {
            _iPostRepository = new PostRepository();
            Posts = _iPostRepository.GetAllPost();
        }
        public List<Post> Posts
        {
            get
            {
                return _posts;
            }
            set
            {
                _posts = value;
                OnPropertyChanged("Posts");
            }
        }
        private List<Post> _posts;

        public Post SelectedPost
        {
            get
            {
                return _selectedPost;
            }
            set
            {
                _selectedPost = value;
                OnPropertyChanged("SelectedPost");
            }
        }
        private Post _selectedPost;
        /// <summary>
        /// Event subscribe by view's controls
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property changed will call this method for PropertyChanged Event
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            //Fire the PropertyChanged event in case somebody subscribed to it
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
