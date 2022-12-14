using System.Text.Json.Serialization;

namespace webapi.Models;

public class Super {
    public Guid super_id {get; set;}
    public string nombre {get;set;}
    public int edad {get;set;}
    public string image_link {get;set;}
    public string rol_super {get;set;}
    public string relaciones {get;set;}
    public string origen {get;set;}

    //[JsonIgnore]
    public virtual ICollection<RasgoSuper> RasgosSuper {get; set;}
    //[JsonIgnore]
    public virtual ICollection<Evento> Eventos {get; set;}
    //[JsonIgnore]
    public virtual ICollection<Patrocinador> Patrocinadores {get; set;}
    [JsonIgnore]
    public virtual ICollection<Pelea> Peleas {get; set;}
}