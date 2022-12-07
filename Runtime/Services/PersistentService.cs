using Newtonsoft.Json;
using UnityEngine;

public class PersistentService : MonoBehaviour {
    public static void SaveData(object item, string key) {
        string output = JsonConvert.SerializeObject(item);
        PlayerPrefs.SetString(key, output);
    }

    public static T GetData<T>(string key) {
        string data = PlayerPrefs.GetString(key);
        return JsonConvert.DeserializeObject<T>(data);
    }
}
