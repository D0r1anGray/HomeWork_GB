package linkedlist;

import linkedlist.core.HWlist;
import linkedlist.core.impl.HWlinkList;

public class Main {
    public static void main(String[] args) {

        HWlist<Integer> list = new HWlinkList<>();

        list.add(10);
        list.add(2);
        list.add(6);
        System.out.println("Список из трёх элементов: " + list);
        System.out.println("Размер списка: " + list.size()+ "\n");
//        System.out.println(list.node(1));

        list.add(1,7);
        System.out.println("Добавили на второе место элемент: " + list);
        System.out.println("Размер списка: " + list.size()+ "\n");
//        System.out.println(list.node(2));

        list.add(0,8);
        System.out.println("Добавили в начало элемент: " + list);
        System.out.println("Размер списка: " + list.size()+ "\n");
//        System.out.println(list.node(3));

        list.remove(2);
        System.out.println("Удалили третий элемент: " + list);
        System.out.println("Размер списка: " + list.size()+ "\n");
 //       System.out.println(list.node(3));
        
        System.out.println("Первый элемент списка: " + ((HWlinkList<Integer>) list).getFirst());
        System.out.println("Последний элемент списка: " + ((HWlinkList<Integer>) list).getLast());

    }
}