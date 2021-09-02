package JavaExercises_1.Example2;

public class Assignment {
    public static void main(String[] args) {
        Tank tank1 = new Tank();
        Tank tank2 = new Tank();
        tank1.level = 9;
        tank2.level = 47;
        System.out.printf("1: tank 1 level: %d, " +
                "tank 2 level: %d%n",
                tank1.level, tank2.level);
        System.out.printf("2: tank 1 level: %d, " +
                "tank 2 level: %d%n",
                tank1.level, tank2.level);
        System.out.printf("3: tank 1 level: %d, " +
                "tank 2 level: %d%n",
                tank1.level, tank2.level);
    }
}
