# Extensions

This section describes the different extensions supported:

## Forms

Radio buttons:

```````````````````````````````` example
sex = (x) male () female
.
<label>Sex:</label> 
<input type="radio" name="sex" id="male" value="male" checked="checked"/><label for="male">Male</label>
<input type="radio" name="sex" id="female" value="female"/><label for="female">Female</label>  
````````````````````````````````

Check boxes:

```````````````````````````````` example
phones = [] Android [x] iPhone [x] Blackberry
.
<label>Phones:</label> 
<input type="checkbox" name="phones" id="Android" value="Android"/><label for="Android">Android</label>
<input type="checkbox" name="phones" id="iPhone" value="iPhone" checked="checked"/><label for="iPhone">iPhone</label>
<input type="checkbox" name="phones" id="Blackberry" value="Blackberry" checked="checked"/><label for="Blackberry">Blackberry</label>
````````````````````````````````

Drop down:

```````````````````````````````` example
city = {BOS, SFO, (NYC)}
.
<label for="city">City:</label>
<select id="city" name="city">
  <option value="BOS">BOS</option>
  <option value="SFO">SFO</option>
  <option value="NYC" selected="selected">NYC</option>
</select>
````````````````````````````````

Required fields:

```````````````````````````````` example
zip code* = ________
.
<label for="zip-code" class="required-label">Zip code*:</label>
<input type="text" name="zip-code" id="zip-code" class="required-input"/>
````````````````````````````````
