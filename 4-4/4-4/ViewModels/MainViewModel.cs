using _4_4.Models;
using System;
using System.Collections.Generic;

namespace _4_4.ViewModels;

public class MainViewModel : ViewModelBase
{
    
    public List<BlogsEntity> BlogsEntities { get; set; }
    public List<NewsEntity> NewsEntities { get; set; }
    
    public MainViewModel()
    {
        
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity()
            {
                Article = "Holidays in France`s mountains",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque urna leo, sodales at lobortis vitae, sagittis nec sapien. Nullam condimentum tempus libero nec blandit. Fusce maximus est a est consequat pellentesque. Nam lobortis odio id volutpat pretium. Aliquam eu suscipit ipsum, eget egestas enim. Sed venenatis fermentum dui. Cras lacus turpis, placerat eu sapien a, vehicula convallis lacus. Aliquam a magna hendrerit purus ornare viverra. Donec rutrum consectetur neque, in commodo turpis. Nullam blandit nulla quis enim dictum vehicula. Praesent semper ac felis ut tempus. Nam pellentesque, justo quis finibus porttitor, turpis turpis iaculis enim, non pretium turpis ligula sit amet ante. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\nNullam faucibus velit vitae massa consectetur blandit. Aliquam et arcu a arcu lobortis pulvinar. Donec ornare tincidunt est ac hendrerit. Maecenas pulvinar enim eu sem ultrices, vitae consectetur urna cursus. Nulla aliquam imperdiet erat, placerat pulvinar nisi ornare egestas. Sed dapibus quis dolor eget aliquet. Proin ornare mi vitae dui semper tincidunt. Nulla et aliquam nisi, id dictum diam. Vivamus lacus nibh, auctor in dapibus non, consectetur dapibus magna. Cras at arcu ante. Donec nibh lorem, pellentesque sed turpis non, porttitor pharetra eros. Aenean rhoncus semper mi, ut ultrices tellus malesuada a. Mauris tortor augue, fermentum ac dignissim eget, tincidunt nec felis. Suspendisse imperdiet faucibus sapien, vel semper velit volutpat tempus. Nulla sit amet mauris id nunc varius venenatis at nec ante. Suspendisse viverra sodales diam.\r\n\r\n",
                ImagePath = "\"C:\\Users\\mboro\\source\\repos\\4-4\\4-4\\4-4\\Mountains.jpg\"",
                Tags = new List<string> {"Tag1", "Tag2", "Tag3"}
            },
            
            
            
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque urna leo, sodales at lobortis vitae, sagittis nec sapien. Nullam condimentum tempus libero nec blandit. Fusce maximus est a est consequat pellentesque. Nam lobortis odio id volutpat pretium. Aliquam eu suscipit ipsum, eget egestas enim. Sed venenatis fermentum dui. Cras lacus turpis, placerat eu sapien a, vehicula convallis lacus. Aliquam a magna hendrerit purus ornare viverra. Donec rutrum consectetur neque, in commodo turpis. Nullam blandit nulla quis enim dictum vehicula. Praesent semper ac felis ut tempus. Nam pellentesque, justo quis finibus porttitor, turpis turpis iaculis enim, non pretium turpis ligula sit amet ante. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\n", 
                PostingTime = DateTime.Now },
            new() { Text = "Nullam faucibus velit vitae massa consectetur blandit. Aliquam et arcu a arcu lobortis pulvinar. Donec ornare tincidunt est ac hendrerit. Maecenas pulvinar enim eu sem ultrices, vitae consectetur urna cursus. Nulla aliquam imperdiet erat, placerat pulvinar nisi ornare egestas. Sed dapibus quis dolor eget aliquet. Proin ornare mi vitae dui semper tincidunt. Nulla et aliquam nisi, id dictum diam. Vivamus lacus nibh, auctor in dapibus non, consectetur dapibus magna. Cras at arcu ante. Donec nibh lorem, pellentesque sed turpis non, porttitor pharetra eros. Aenean rhoncus semper mi, ut ultrices tellus malesuada a. Mauris tortor augue, fermentum ac dignissim eget, tincidunt nec felis. Suspendisse imperdiet faucibus sapien, vel semper velit volutpat tempus. Nulla sit amet mauris id nunc varius venenatis at nec ante. Suspendisse viverra sodales diam.\r\n\r\n", 
                PostingTime = DateTime.Now.AddDays(-1) }
        };
    }
    
}

