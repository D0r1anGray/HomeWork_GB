import java.util.HashMap;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.Comparator;
import java.util.stream.Collectors;


public class Attestat {
    public static void main(String[] args) {
        HashMap<String, List<String>> phoneBook = new HashMap<>();

        addToPhoneBook(phoneBook, "Иванов", "8-925-456-21-34");
        addToPhoneBook(phoneBook, "Гаязов", "8-974-321-67-88");
        addToPhoneBook(phoneBook, "Ведьмаков", "8-933-124-78-99");
        addToPhoneBook(phoneBook, "Иванов", "44-124-124-22-22");
        addToPhoneBook(phoneBook, "Ведьмаков", "8-966-666-66-66");

        //List<Map.Entry<String, List<String>>> sortedList = new ArrayList<>(phoneBook.entrySet());

        List<Map.Entry<String, List<String>>> sortedList =
                phoneBook.entrySet()
                        .stream()
                        .sorted(new CompareToSize())
                        .collect(Collectors.toList());

        for (Map.Entry<String, List<String>> entry : sortedList) {
            String surname = entry.getKey();
            List<String> phones = entry.getValue();
            System.out.println("Фамилия:" + surname + ", Номера телефонов: " + phones);
        }
    }

    static class CompareToSize implements Comparator<Map.Entry<String, List<String>>> {
        public int compare(Map.Entry<String, List<String>> entry1, Map.Entry<String, List<String>> entry2) {
            return Integer.compare(entry2.getValue().size(), entry1.getValue().size());
        }
    }
    static void addToPhoneBook(HashMap<String, List<String>> phoneBook,
                                       String name, String phone) {
        phoneBook.computeIfAbsent(name, k -> new ArrayList<>()).add(phone);
    }
}
