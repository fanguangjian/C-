namespace HelloWorld.Models{

    public class ComputerSnake{
            // private string _motherboard;
            public int computer_id { get; set; }
            public string motherboard {get; set; }
            public int? cpu_cores {get; set; }
            public bool has_wifi {get; set; }
            public bool has_lte {get; set; }
            public DateTime? release_date {get; set; }
            public decimal price {get; set; }
            public string video_card {get; set; }

            public ComputerSnake(){
                if(this.video_card == null){
                    video_card = "";
                }
                if(this.motherboard == null){
                    motherboard = "";
                }
                if(this.cpu_cores == null){
                    cpu_cores = 0;
                }
            }

    }

}


