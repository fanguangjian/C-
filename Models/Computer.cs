namespace HelloWorld.Models{

    public class Computer{
            // private string _motherboard;
            public int ComputerId { get; set; }
            public string Motherboard {get; set; }
            public int? CPUCores {get; set; }
            public bool HasWifi {get; set; }
            public bool HasLTE {get; set; }
            public DateTime ReleaseDate {get; set; }
            public decimal Price {get; set; }
            public string VideoCard {get; set; }

            public Computer(){
                if(this.VideoCard == null){
                    VideoCard = "";
                }
                if(this.Motherboard == null){
                    Motherboard = "";
                }
                if(this.CPUCores == null){
                    CPUCores = 0;
                }
            }

    }

}


