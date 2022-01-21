#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int rand_number() {
    srand(time(NULL));
    return rand() % 10 + 1;
}

int main() {
    int answer = rand_number();

    int input, count = 0;
    while (1) {
        printf("Guess a number: ");
        scanf("%d", &input);
        count++;

        if (input == answer) {
            printf("You win! You guessed %d times", count);
            break;
        }
        else if (input > answer) {
            printf("Too high!\n");
        }
        else {
            printf("Too low!\n");
        }
    }

    return 0;
}
