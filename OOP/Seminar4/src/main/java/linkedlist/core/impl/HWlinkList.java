package linkedlist.core.impl;


import linkedlist.core.HWlist;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class HWlinkList<T> implements HWlist<T> {
    private int size = 0;
    private Node<T> first;
    private Node<T> last;

    public HWlinkList(int size, Node<T> first, Node<T> last) {
        this.size = size;
        this.first = first;
        this.last = last;
    }

    public Node<T> getLast() {
        return last;
    }

    public HWlinkList() {
        this.size = 0;
        this.first = null;
        this.last = null;
    }

    @Override
    public void add(T elem) {
        Node<T> node = new Node<>(elem, null,null);
        if(size == 0){
            first = node;
        }
        else{
            node.prev = last;
            (node.prev).next = node;
            node.next = null;
        }
        last = node;
        size++;

    }

    @Override
    public void add(int index, T elem) {
        if(size == 0 || index == size){
            add(elem);
        } else if (index > size || index < 0) {
            System.out.println("Некорректно указан индекс");
        }
        Node<T> starnode = node(index);
        Node<T> novnode = new Node<>(elem, starnode,starnode.prev);
        if(starnode.prev != null){
            starnode.prev.next = novnode;
        }
        else{
            first = novnode;
        }
        starnode.prev = novnode;
        size++;
    }

    @Override
    public void remove(int index) {
        (node(index).next).prev = node(index).prev;
        (node(index).prev).next = node(index).next;
        size--;
    }

    private Node<T> node(int index){
        Node<T> snode;
        if(index <= size/2){
            snode = first;
            for(int i = 0; i < size; i++){
                if(i == index) {
                    break;
                }
                snode = snode.next;
            }
        }
        else{
            snode = last;
            for(int i = size-1; i > size/2; i--){
                if(i == index) {
                    break;
                }
                snode = snode.prev;
            }
        }
        return snode;
    }

    @Override
    public T get(int index) {
        if(index == 0){
            return first.item;
        } else if (index == size-1) {
            return last.item;
        }
        return node(index).item;
    }

    @Override
    public int size() {
        return size;
    }


    private static class Node<T>{
        T item;
        Node<T> next;
        Node<T> prev;

        public Node(T item, Node<T> next, Node<T> prev) {
            this.item = item;
            this.next = next;
            this.prev = prev;
        }

        @Override
        public String toString() {
            if(this.next == null){
                return "Node{" +
                        "item=" + item +
                        ", next=" + "null" +
                        ", prev=" + prev.item +
                        '}';
            } else if (this.prev == null) {
                return "Node{" +
                        "item=" + item +
                        ", next=" + next.item +
                        ", prev=" + "null" +
                        '}';
            }
            return "Node{" +
                    "item=" + item +
                    ", next=" + next.item +
                    ", prev=" + prev.item +
                    '}';
        }
    }

    @Override
    public String toString() {
        StringBuilder stringBuilder = new StringBuilder("[");
        int index = 0;
        while(index < size){
            stringBuilder.append(node(index).item).append(", ");
            index ++;
        }
        if(stringBuilder.length() == 1){
            return "[]";
        }
        stringBuilder.deleteCharAt(stringBuilder.length() - 1).deleteCharAt(stringBuilder.length() - 1);
        stringBuilder.append("]");
        return stringBuilder.toString();

    }

    //    @Override
//    public Iterator iterator() {
//        return new ListIterator(new HWlinkList<T>());
//    }
}
