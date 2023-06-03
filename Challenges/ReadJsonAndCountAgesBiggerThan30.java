public class Main {

  public static void main(String[] args) {
    String data = "{ \"data\": [ { \"key\": \"vwebrwetb\", \"age\": 12 }, { \"key\": \"tjyrtynety\", \"age\": 51 }, { \"key\": \"qwxadcwxs\", \"age\": 51 },{ \"key\": \"vfxbytut\", \"age\": 51 } ] }";

    String[] objects = data.replace("[", "").replace("]", "").split("\\}, \\{");
    int count = 0;

    for (String object : objects) {
      String[] pairs = object.replace("{", "").replace("}", "").split(",");
      for (String pair : pairs) {
        String[] keyValue = pair.split(":");
        String key = keyValue[0].trim();
        String value = keyValue[1].trim();

        if (key.equals("\"age\"") && Integer.parseInt(value) > 30) {
          count++;
        }
      }
    }
  }
}
