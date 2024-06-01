<script setup>
import { computed, ref } from 'vue'
const props = defineProps(['cheeseArray'])
const totalPrice = computed(() => calculatePrice())

function calculatePrice() {
    if (selectedCheese.value.pricePerKilo)
        return (ammountKg.value * selectedCheese.value.pricePerKilo)
}


let selectedCheese = ref({})
let ammountKg = ref(0)

</script>

<template>
    <div>
        <h1>But at what cost?</h1>
        <div class="row">
            <div class="col-3">
                <div class="input-group mb-3">
                    <label class="input-group-text" for="inputGroupSelect01">Cheese</label>
                    <select class="form-select" id="inputGroupSelect01" v-model="selectedCheese" >
                        <option v-for="cheese in props.cheeseArray" :key="cheese.name" :value="cheese" selected>{{cheese.name}}</option>
                    </select>
                </div>
                <div class="input-group mb-3">
                    <span class="input-group-text" id="inputGroup-sizing-default" >Ammount (Kg)</span>
                    <input type="number" v-model="ammountKg" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default">
                </div>
            </div>
            
            <div class="col-3">
                <h3>${{ totalPrice }}</h3>
            </div>
        </div>
    </div>


</template>

<style scoped>

</style>