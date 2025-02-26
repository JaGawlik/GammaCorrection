.code
GammaCorrectionCode proc

;RCX->RDX->R8->R9
;							RCX			RDX
;GammaCorrectionCode(float[] pixel, int gamma);

	movdqu xmm0, oword ptr[rcx]	        ;rgb bazowe
	                    	            ;xmm1 potega
                          
    mov r9, rdx                         ;inicjalizacja petli

    movaps xmm2, xmm0

    cmp r9, 0h 
    je sqr

pow:
    cmp r9, 1h                          ;sprawdzanie petli
    je exit

    mulps xmm2, xmm0                    ;mnozenie wektorowe

    sub r9, 1
    jmp pow

sqr:
     mov rax, 3ff0000000000000h       ;64-bitowa reprezentacja liczby 1.0
     movq xmm2, rax

     sqrtps xmm2, xmm0                ;pierwiastek kwadratowy
 

exit:

    pextrd dword ptr[rcx+0], xmm2, 0    ;zapis do odpowiedniego miejsca w rejestrze
    pextrd dword ptr[rcx+4], xmm2, 1
    pextrd dword ptr[rcx+8], xmm2, 2
    ret

GammaCorrectionCode endp
end
   