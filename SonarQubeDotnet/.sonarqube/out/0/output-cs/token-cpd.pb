�
OC:\Users\CAIQAUG\Downloads\SonarQube\SonarQubeDotnet\SonarQubeDotnet\Program.cs
Console 
. 
	WriteLine 
( 
$str !
)! "
;" #�
VC:\Users\CAIQAUG\Downloads\SonarQube\SonarQubeDotnet\SonarQubeDotnet\OrderProcessor.cs
	namespace 	$
ComplexityAndMaintenance
 "
{ 
public 

class 
OrderProcessor 
{ 
public 
void 
ProcessOrder  
(  !
int! $
orderId% ,
,, -
string. 4

,B C
stringD J
addressK R
,R S
stringT Z
phone[ `
,` a
boolb f
	isExpressg p
)p q
{ 	
if

 
(

 
orderId

 
<=

 
$num

 
||

 
string

  &
.

& '


' 4
(

4 5


5 B
)

B C
)

C D
{ 
Console 
. 
	WriteLine !
(! "
$str" 7
)7 8
;8 9
return
;
} 
switch 
( 

.! "
ToLower" )
() *
)* +
)+ ,
{ 
case 
$str 
: 
Console 
. 
	WriteLine %
(% &
$str& I
)I J
;J K
break 
; 
case 
$str 
: 
Console 
. 
	WriteLine %
(% &
$str& H
)H I
;I J
break 
; 
case 
$str 
: 
Console 
. 
	WriteLine %
(% &
$str& D
)D E
;E F
break 
; 
default 
: 
Console 
. 
	WriteLine %
(% &
$str& ?
)? @
;@ A
break 
; 
} 
if   
(   
!   
string   
.   

(  % &
address  & -
)  - .
)  . /
{!! 
if"" 
("" 
address"" 
."" 
Length"" "
<""# $
$num""% '
)""' (
{## 
Console$$ 
.$$ 
	WriteLine$$ %
($$% &
$str$$& =
)$$= >
;$$> ?
}%% 
else&& 
if&& 
(&& 
address&&  
.&&  !
Length&&! '
>&&( )
$num&&* -
)&&- .
{'' 
Console(( 
.(( 
	WriteLine(( %
(((% &
$str((& <
)((< =
;((= >
})) 
}** 
if,, 
(,, 
!,, 
string,, 
.,, 

(,,% &
phone,,& +
),,+ ,
&&,,- /
phone,,0 5
.,,5 6
Length,,6 <
!=,,= ?
$num,,@ B
),,B C
{-- 
Console.. 
... 
	WriteLine.. !
(..! "
$str.." 9
)..9 :
;..: ;
}// 
if11 
(11 
	isExpress11 
)11 
{22 
Console33 
.33 
	WriteLine33 !
(33! "
$str33" >
)33> ?
;33? @
}44 
}55 	
}66 
}77 �
RC:\Users\CAIQAUG\Downloads\SonarQube\SonarQubeDotnet\SonarQubeDotnet\Calculator.cs
	namespace 	&
PoorNamingAndAccessibility
 $
{ 
public 

class 

Calculator 
{ 
public 
int 
	Calculate 
( 
int  
a! "
," #
int$ '
b( )
,) *
string+ 1
	operation2 ;
); <
{ 	
switch 
( 
	operation 
) 
{ 
case		 
$str		 
:		 
return

 
a

 
+

 
b

  
;

  !
case 
$str 
:  
return 
a 
- 
b  
;  !
case
$str
:
return 
a 
* 
b  
;  !
case 
$str 
: 
if 
( 
b 
== 
$num 
) 
{ 
throw 
new !!
DivideByZeroException" 7
(7 8
)8 9
;9 :
} 
return 
a 
/ 
b  
;  !
default 
: 
throw 
new %
InvalidOperationException 7
(7 8
$str8 L
)L M
;M N
} 
} 	
} 
} �
SC:\Users\CAIQAUG\Downloads\SonarQube\SonarQubeDotnet\SonarQubeDotnet\BankAccount.cs
	namespace 	
ComplexCodeExample
 
{ 
public 

class 
BankAccount 
{ 
private 
double 
balance 
; 
private 
string 
password 
;  
public 
BankAccount 
( 
double !
initialBalance" 0
,0 1
string2 8
password9 A
)A B
{		 	
balance

 
=

 
initialBalance

 $
;

$ %
this 
. 
password 
= 
password $
;$ %
} 	
public 
double 
Withdraw 
( 
double %
amount& ,
,, -
string. 4
passwordAttempt5 D
)D E
{ 	
if 
( 
passwordAttempt 
!=  "
password# +
)+ ,
{ 
throw 
new '
UnauthorizedAccessException 5
(5 6
$str6 J
)J K
;K L
} 
if 
( 
amount 
< 
$num 
) 
{ 
throw 
new 
ArgumentException +
(+ ,
$str, E
)E F
;F G
} 
else 
if 
( 
amount 
== 
$num  
)  !
{ 
Console 
. 
	WriteLine !
(! "
$str" ;
); <
;< =
} 
else 
if 
( 
amount 
> 
balance %
)% &
{ 
throw 
new %
InvalidOperationException 3
(3 4
$str4 H
)H I
;I J
}   
else!! 
if!! 
(!! 
balance!! 
-!! 
amount!! %
<!!& '
$num!!( *
)!!* +
{"" 
Console## 
.## 
	WriteLine## !
(##! "
$str##" 8
)##8 9
;##9 :
balance$$ 
-=$$ 
amount$$ !
;$$! "
}%% 
else&& 
{'' 
balance(( 
-=(( 
amount(( !
;((! "
})) 
if++ 
(++ 
balance++ 
<++ 
$num++ 
)++ 
{,, 
throw-- 
new-- %
InvalidOperationException-- 3
(--3 4
$str--4 L
)--L M
;--M N
}.. 
return00 
balance00 
;00 
}11 	
}22 
}33 