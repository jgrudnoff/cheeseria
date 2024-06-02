<script setup>
import { computed, ref } from 'vue'
import { CalculateCheesePrice } from "../services/product.service"
const props = defineProps(['cheeseArray'])
const totalPrice = computed(() => calculatePrice())

function calculatePrice() {
    return CalculateCheesePrice(selectedCheese.value.pricePerKilo, ammountKg.value)
}

let selectedCheese = ref({})
let ammountKg = ref(0)

</script>

<template>
    <div class="calculater-widget">
        <div class="row title-container">
            <h1>But at what cost? - ${{ totalPrice }}</h1>
        </div>
        <div class="row calc-container">
            <div class="col-6">
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

        </div>
    </div>
</template>

<style scoped>

.title-container{
    text-align: center;
    margin-bottom: 1rem;
}

.calc-container{

    justify-content: center;
}

.total-price-container{
    
    align-content: center;
    font-size: 40px;
}

.calculater-widget{
    width: 50%;
    margin: 2rem;
    padding-top: 1rem;
    padding-bottom: 1rem;
    border-radius: 12px;
    box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
    background-color: var(--color-body-background);
}

</style>