import java.util.*;

// there are 3 types of set : Tree set, hash set, linkedhash set
public class Sett {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        Set<Integer> s = new HashSet<>(n);
        for(int i = 0 ; i < n;i++){
            int temp = sc.nextInt();
            s.add(temp);
        }
        s.forEach(System.out::println);
        System.out.println();
        Set<Integer> x = new LinkedHashSet<>(n);
        for(int i = 0 ; i < n;i++){
            int temp = sc.nextInt();
            x.add(temp);
        }
        x.remove(4);
        System.out.println(x.size());
        x.forEach(System.out::println);
        
        System.out.println();
        Set<Integer> t = new LinkedHashSet<>(n);
        for(int i = 0 ; i < n;i++){
            int temp = sc.nextInt();
            t.add(temp);
        }
        
        t.forEach(System.out::println);
    }
}
