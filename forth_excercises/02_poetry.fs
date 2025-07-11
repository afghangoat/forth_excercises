\ A Hungarian poetry about the Habsburgs

: newline 10 emit ;

: labanc dup . ." labanc fészkel nemes országunkban, " newline dup . ." ördög fia, mind a szép hazánkban." newline ." Az labancság takarodjék nemes országunkból!" newline ." Már csak " 1 - dup . ." labancot űzűnk nagy hazánkból!" newline newline ;
: fixed-labanc dup 1 < if ." Már nincs több labanc hazafiak, nagy hazánk szabad!" newline else labanc then ;
: labanc-verse 99 1 do fixed-labanc loop ;

80 labanc-verse