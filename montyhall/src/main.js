import Vue from 'vue'
import App from './App'

new Vue({
    render: h => h(App) // é usado esse padrão quando vocÊ chama vue create
    //render(createElement) { 
    //   return createElement(App)
    //}
}).$mount("#app")