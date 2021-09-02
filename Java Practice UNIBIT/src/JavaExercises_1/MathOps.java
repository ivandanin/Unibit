package JavaExercises_1;

import java.util.Random;

public class MathOps {
    public static void main(String[] args) {
        Random random = new Random(47);
        int i;
        int j;
        int k;

        j = random.nextInt(100) + 1;
        System.out.println("j: " + j);

        k = random.nextInt(100) + 1;
        System.out.println("k: " + k);

        i = j + k;
        System.out.println("j + k = " + i);

        i = j - k;
        System.out.println("j - k = " + i);

        i = k / j;
        System.out.println("k / j = " + i);

        i = k * j;
        System.out.println("k * j = " + i);

        i = k % j;
        System.out.println("k % j = " + i);

        j %= k;
        System.out.println("j %= k = " + j);

        float u;
        float v;
        float w;

        v = random.nextFloat();
        System.out.println("v = " + v);

        w = random.nextFloat();
        System.out.println("w = " + w);

        u = v + w;
        System.out.println("v + w = " + u);

        u = v - w;
        System.out.println("v - w = " + u);

        u = v * w;
        System.out.println("v * w = " + u);

        u = v / w;
        System.out.println("v / w = " + u);

        u += v;
        System.out.println("u += v = " + u);

        u -= v;
        System.out.println("u -= v = " + u);

        u *= v;
        System.out.println("u *= v = " + u);

        u /= v;
        System.out.println("u /= v = " + u);

    }
}
