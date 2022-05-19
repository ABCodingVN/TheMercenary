import React from 'react';
import Header from '../../Componets/Header/Header';
import Banner from '../../Componets/Banner/Banner';
import CategoryItems from '../../Componets/CategoryItems/CategoryItems';
import Product from '../../Componets/Product/ProductMain';





function Home() {
    return( 
        <>
            <Header />
            <CategoryItems />
            <Banner />
            <Product/>
            
        </>
    );
}

export default Home;