if(z = 0) and (s = o) - JG
if(s <> o)            - JL
if (z = 1)            - JE 
if (z = 0)            - JNE
if (s = o) or z=1     - JGE
if (s <> o) or z = 1  - JLE


Just as a quick summary, I wrote this article for two purposes. First, It is interesting, and more knowledge of how your computer works is always helpful. Secondly, there are always programs where flags will be manipulated directly, and it is helpful to know the effects they will have on jumps. For example, something as simple as
CMP eax,ebx
JC somewhere
might confuse most beginning reversers, but hopefully not after this article. Enjoy :)

[Important Note: I will use 8 bit integers for my examples when I write out binary numbers. Just remember that, although 8 bit integers are not commonly used in programming, the same rules that I discuss apply to integers with more bits]

The CMP Instruction:

The CMP instruction operates by performing an implied subtraction of the two operands. This means that the result is not stored in memory. After subtracting them, it does a few quick tests, updating the Z,O,C,S, and P flags. The P, or parity, flag is rarely used, so we'll ignore it in this article for the purpose of brevity.

Binary subtraction is performed by adding the negated version of the second operand from the first. This is just like what you learned in middle school, about how 4+3 = 4 - (-3), and visa versa.
At the end of the article I will explain how this is done, but I'll move onto the more important matters for now since that knowledge is not really needed for cracking or coding.

Sign and Zero Flag:

The four flags that the CMP instruction can set - Z,O,C, and S, are known as the zero, overflow, carry, and sign flags respectively. The zero flag is set whenever the result of the subtraction is equal to zero. This, of course, only occurs when the operands are equal. The sign flag is set when the result of the subtraction is negative. Although we are inclined to think that this means the sign flag in combination with the zero flag are enough to test all > >= < and <=, this is not true, because the result can be negative even if the first number is greater than the second. This is because of overflow.

Overflow Flag:

Signed integers are represented in binary with the same amount of bits as unsigned integers. This means, of course, that the sign must be set in one of the bits of the integer. Signed integers store the sign in the MSB (most significant bit). This means that, while 00000001 converts to 1 in decimal, 10000001 converts to -127. I will discuss why it is -127 and not -1 or -2 later in the article.
When the processor performs subtraction, It wraps around if the subtraction goes below 00000000 or above 11111111. Therefore, if you subtract a negative number from a positive one, or subtract a positive number from a negative one, there is the possibility that the answer will overflow over the boundary. For example, 100 - (-100) is equal to 200, but the highest value an 8 bit signed integer can be is 127, so 200 will wrap through the upper boundary and end up as a negative number, even though it should be positive. The same problem occurs with -100 - 100; It wraps through the low end and ends up positive when it should be negative, causing an underflow. Note that an underflow also sets the overflow flag, and overflow will refer to both overflows and underflows further in the article. The CPU checks for this, and sets the overflow flag if it occurs.

Carry Flag:

The carry flag is set when, if both operands are interpreted as unsigned integers, the first one is greater. This is easy to determine because it occurs whenever the subtraction passes through 00000000 into the higher range (11111111).
For example, 00000001 - 00000010 = 11111111, so carry is set. However, 00000010 - 00000001 = 00000001, so carry is not set.

On to the Jumps!!!

Easy jumps:

JE/JZ - Jump if equal/jump if Z
Jumps if the Z flag is set. This, of course, only occurs when the subtraction equals zero, and therefore when the operands are equal.
JNE/JNZ - Jump if not equal/jump if not Z
Jumps if the Z flag is not set. The Z flag is set if and only if the operands are equal, so if the Z flag is not set, they must not be equal :)

JC/JNC: Jump if carry flag is set / Jump if carry flag is not set. Should need no explaining.

JS/JNS: Jump if sign flag is set / Jump if sign flag is not set.

JO/JNO: Jump if overflow flag is set / Jump if overflow flag is not set.

Unsigned Jumps:

JAE/JNB - Jump if above or equal/Jump if not below
Jumps if the carry flag is not set. This always occurs if the first operand is higher as an unsigned integer (so a most significant bit of 1 is interpreted as 2^7 higher rather than a minus sign)

JA/JNBE - Jump if above / Jump if not below or equal
Jumps if the carry flag is not set and the z flag is not set. Checks for above the same way as JA, but makes sure they aren't equal as well.

JB/JNAE - Jump if below / Jump if not above or equal
Jumps if the carry flag is set. This occurs whenever the first operand is lower, since then the result would be below 0 but wraps around to high numbers.

JBE/JNA - Jump if below or equal / Jump if not above
Jumps if the carry flag is set or the z flag is set. Since the carry flag only tells us that the first one is below, we must check the z flag as well to check if they are equal.

Signed Jumps: (these ones need a bit more explaining - also, remember that the sign flag is set if the result of the subtraction is negative)

JGE/JNL - Jump if greater than or equal / jump if not less
Jumps if the sign flag is equal to the overflow flag. (prepares for long and difficult explanation)

If the result is negative, this can mean one of two things. Either the first number is smaller than the second, evaluating into a negative answer, or because a negative number was subtracted from a positive one, and the result was large enough to cause an overflow.
If the result is not negative, either the first number is higher than the second, or a positive number was subtracted from a negative number, and the result was low enough to cause an overflow.
Therefore, we can do a little pseudocode if chart -
if(negative){
....if(overflow),first number was positive and second was negative - > first is greater
....if(not overflow), first number was lower - if a - b < 0, a < b.
}
if(not negative){
....if(overflow),first number was negative and second was positive -> first is lower
....if(not overflow), first number was higher OR they were equal :) - if a - b >= 0, a >= b
}

Looking at this, we can see all of our signed jumps fairly easily! JGE/JNL, as we saw before, is true when S=1 and O=1, or when S=0 and O=0, and therefore jumps when S=O

JG/JNLE - Jump if greater / Jump if not less or equal
Jumps if sign flag = overflow flag and zero flag is not true. This one is the similar to JGE, but must make sure the operands aren't equal.

JL/JNGE - Jump if less / Jump if not greater or equal
Jumps if sign flag != overflow. See the conditional chart above.

JLE/JNG - Jump if less or equal / Jump if not greater
Jumps if sign flag != overflow OR zero flag is set
Same as JL but checks to see if they are equal as well.

There two other conditional jumps, though they are far less common:

JCXZ - Jump if CX register is equal to zero
JECXZ - Jump if ECX register is equal to zero


