\ hello world forth program.
: add-two 2 + ;
: even-or-odd 2 mod 0 = if ." Even" else ." Odd" then ;
: is-negative 0 < if ." Negative" else ." Non-Negative" then ;
: is-zero 0 = if ." Zero" else ." Non-Zero" then ;
: count-to-100 100 1 do i . loop ;

\ ." Hello World!" CR
\ .( sum of 10 and 25 is ) 10 25 + add-two add-two .

\ -20
\ is-negative