let words = 'How to CapitAlize Init-ial Lett%Ers Except For Prepositions'
let pres = ['above', 'across', 'against', 'along', 'among', 'around', 'at', 'before', 'behind', 'below', 'beneath', 
'beside', 'between', 'by', 'down', 'from', 'in', 'into', 'near', 'of', 'off', 'on', 'to', 'toward',
 'under', 'upon', 'with', 'within']
 
words.replace(/\b(?<![\-,\%])([a-z]*)/g, function(match, $1) {
    if(pres.includes($1.toLowerCase())) {
        return $1
    }
    return match.replace(/^([a-z]{1})/, function(match, $1) {
    return $1.toUpperCase()
})
})
