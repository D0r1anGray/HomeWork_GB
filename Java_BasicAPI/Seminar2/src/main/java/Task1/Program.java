package Task1;

import java.util.Objects;

class Answer {
    public static StringBuilder answer(String QUERY, String PARAMS){
        // Напишите свое решение ниже
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.append(QUERY);

        PARAMS = PARAMS.replace("{","")
                .replace("}","");

        String[] newParams = PARAMS.split(", ");

        for(int i = 0; i < newParams.length; i++){
            String[] temp = newParams[i].split(":");
            if(Objects.equals(temp[1], "\"null\"")){
                newParams[i] = "";
            }
            else{
                temp[0] = temp[0].replace("\"", "");
                temp[1] = temp[1].replace("\"", "'");
                newParams[i] = temp[0] + "=" + temp[1];
            }
        }

        for(int j = 0; j < newParams.length; j++){
            if(!Objects.equals(newParams[j], "")){
                if(newParams[j] == newParams[0] || Objects.equals(newParams[j - 1], "")){
                    stringBuilder.append(newParams[j]);
                }
                else{
                    stringBuilder.append(" and " + newParams[j]);
                }
            }

        }
        return stringBuilder;
    }
}

public class Program {
    public static void main(String[] args) {
        String QUERY = "";
        String PARAMS = "";

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            QUERY = "select * from students where ";
            PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}";
        }
        else {
            QUERY = args[0];
            PARAMS = args[1];
        }

        Answer ans = new Answer();
        System.out.println(ans.answer(QUERY, PARAMS));
    }
}
