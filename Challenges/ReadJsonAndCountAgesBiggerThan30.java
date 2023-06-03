public class Main {

  /*
    In this example, we first break down the JSON array into individual objects, then for each object, we break it down into individual key-value pairs. 
    Then, for each key-value pair, if the key is "age" and the value is greater than 30, we increment our count.
    This approach it assumes that each object in the array is separated by "}, {" and not "},{". 
    It would not handle nested objects or arrays, and it would not handle whitespace or formatting differences correctly. 
    It also wouldn't handle string values that contain commas or colons.
  */
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
